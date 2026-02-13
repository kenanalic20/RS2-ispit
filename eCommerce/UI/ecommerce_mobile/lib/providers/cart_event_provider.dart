import 'package:ecommerce_mobile/model/cart_event.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';

class CartEventProvider extends BaseProvider<CartEvent> {
  CartEventProvider() : super("CartEventIB200116");

  @override
  CartEvent fromJson(dynamic json) {
    return CartEvent.fromJson(json);
  }
}
