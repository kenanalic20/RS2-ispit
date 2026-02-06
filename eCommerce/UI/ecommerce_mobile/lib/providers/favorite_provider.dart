import 'dart:convert';

import 'package:ecommerce_mobile/model/favorite.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:flutter/widgets.dart';
import 'package:http/http.dart' as http;
import 'package:ecommerce_mobile/providers/auth_provider.dart';

class FavoriteProvider extends BaseProvider<FavoriteIB200116> {
  FavoriteProvider() : super("FavoriteIB200116");

  @override
  FavoriteIB200116 fromJson(dynamic json) {
    return FavoriteIB200116.fromJson(json);
  }
}
