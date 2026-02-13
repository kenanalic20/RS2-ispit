import 'package:json_annotation/json_annotation.dart';
import 'asset.dart';

part 'cart_event.g.dart';

@JsonSerializable()
class CartEvent {
  final int id;
  final int? cartId;
  final String? eventType;
  final int? cartItemId;
  final DateTime? createdAt;
  final double? productPrice;
  final String? productName;
  final int? newQuantity;

  CartEvent(
      {this.id = 0,
      this.cartId,
      this.eventType,
      this.cartItemId,
      this.createdAt,
      this.productPrice,
      this.productName,
      this.newQuantity});

  factory CartEvent.fromJson(Map<String, dynamic> json) =>
      _$CartEventFromJson(json);

  Map<String, dynamic> toJson() => _$CartEventToJson(this);

  // // Factory constructor for creating Product from JSON
  // factory Product.fromJson(Map<String, dynamic> json) {
  //   return Product(
  //     id: json['id'] ?? 0,
  //     name: json['name'] ?? '',
  //     code: json['code'] ?? '',
  //     productState: json['productState'] ?? 'ActiveProductState',
  //   );
  // }

  // // Method to convert Product to JSON
  // Map<String, dynamic> toJson() {
  //   return {
  //     'id': id,
  //     'name': name,
  //     'code': code,
  //     'productState': productState,
  //   };
  // }

  // @override
  // String toString() {
  //   return 'Product{id: $id, name: $name, code: $code, productState: $productState}';
  // }
}
