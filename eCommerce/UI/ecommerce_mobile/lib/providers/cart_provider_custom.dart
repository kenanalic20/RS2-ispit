import 'package:ecommerce_mobile/model/cart.dart';
import 'package:ecommerce_mobile/model/cart_custom.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:flutter/widgets.dart';
import 'package:collection/collection.dart';

class CartProviderCustom extends BaseProvider<CartCustom> {
  CartProviderCustom() : super("Cart");

  @override
  CartCustom fromJson(dynamic json) {
    return CartCustom.fromJson(json);
  }
}
