import 'package:ecommerce_mobile/model/cart.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/providers/auth_provider.dart';
import 'package:ecommerce_mobile/providers/cart_provider_custom.dart';
import 'package:flutter/widgets.dart';
import 'package:collection/collection.dart';

class CartProvider with ChangeNotifier {
  Cart cart = Cart();
  final CartProviderCustom _cartProviderCustom = CartProviderCustom();
  bool _isSync = false;
  //mapiranje custom carta u lokalni
  loadData() async {
    try {
      var response =
          await _cartProviderCustom.get(filter: {"fts": AuthProvider.username});
      print(AuthProvider.username);
      var apiCart = response.items?.first;
      cart = Cart();

      if (apiCart != null) {
        cart.items = apiCart.cartItems
            .map((cartItems) => CartItem(cartItems.product!, cartItems.count))
            .toList();
      }
      notifyListeners();
    } catch (e) {
      print('Error loading cart: $e');
    }
  }

  syncData() async {
    await _cartProviderCustom.insert({
      "username": AuthProvider.username,
      "cartItems": cart.items
          .map((item) => {'productId': item.product.id, 'quantity': item.count})
          .toList()
    });
  }

  addToCart(Product product) async {
    if (_isSync) {
      print('Already syncing, please wait...');
      return;
    }
    _isSync = true;
    try {
      if (findInCart(product) != null) {
        findInCart(product)?.count++;
      } else {
        cart.items.add(CartItem(product, 1));
      }
      notifyListeners();
      await syncData();
    } catch (e) {
      print("error adding to cart $e");
    } finally {
      _isSync = false;
    }
  }

  removeFromCart(Product product) async {
    cart.items.removeWhere((item) => item.product.id == product.id);
    var request = {
      'username': AuthProvider.username,
      'cartItems': [
        {'productId': product.id, 'quantity': 0},
        //   ...cart.items.map((item) => {
        //   'productId': item.product.id,
        //   'quantity': item.count  // Use actual count, not 0!
        // })
      ]
    };
    await _cartProviderCustom.insert(request);
    notifyListeners();
  }

  CartItem? findInCart(Product product) {
    CartItem? item =
        cart.items.firstWhereOrNull((item) => item.product.id == product.id);

    return item;
  }
}
