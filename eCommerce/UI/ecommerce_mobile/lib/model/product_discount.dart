import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';

part 'product_discount.g.dart';

@JsonSerializable()
class ProductDiscount {
  final int id;
  final int? productId;
  final Product? product;
  final double discount;
  final DateTime? beganAt;
  final DateTime? validUntil;

  ProductDiscount(
      {this.id = 0,
      this.productId,
      this.product,
      this.discount = 0.0,
      this.beganAt,
      this.validUntil});

  factory ProductDiscount.fromJson(Map<String, dynamic> json) =>
      _$ProductDiscountFromJson(json);

  Map<String, dynamic> toJson() => _$ProductDiscountToJson(this);
}
