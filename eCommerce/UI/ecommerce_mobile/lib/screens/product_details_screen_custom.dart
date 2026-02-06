import 'dart:convert';
import 'dart:io';

import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/product_type.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/unit_of_measure.dart';
import 'package:ecommerce_mobile/providers/auth_provider.dart';
import 'package:ecommerce_mobile/providers/favorite_provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';
import 'package:ecommerce_mobile/providers/product_type_provider.dart';
import 'package:ecommerce_mobile/providers/unit_of_measure_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/favorite_list.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:provider/provider.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
// import 'package:file_picker/file_picker.dart';

class ProductDetailsScreenCustom extends StatefulWidget {
  Product? product;
  ProductDetailsScreenCustom({super.key, this.product});

  @override
  State<ProductDetailsScreenCustom> createState() =>
      _ProductDetailsScreenCustomState();
}

class _ProductDetailsScreenCustomState
    extends State<ProductDetailsScreenCustom> {
  final formKey = GlobalKey<FormBuilderState>();

  Map<String, dynamic> _initalValue = {};

  late ProductProvider productProvider;
  late UnitOfMeasureProvider unitOfMeasureProvider;
  late ProductTypeProvider productTypeProvider;
  late FavoriteProvider favoriteProvider;

  SearchResult<UnitOfMeasure>? unitOfMeasures;
  SearchResult<ProductType>? productTypes;
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    productProvider = Provider.of<ProductProvider>(context, listen: false);
    unitOfMeasureProvider =
        Provider.of<UnitOfMeasureProvider>(context, listen: false);
    productTypeProvider =
        Provider.of<ProductTypeProvider>(context, listen: false);
    favoriteProvider = Provider.of<FavoriteProvider>(context, listen: false);

    _initalValue = {
      "name": widget.product?.name,
      "code": widget.product?.code,
      "unitOfMeasureId": widget.product?.unitOfMeasureId,
      "productTypeId": widget.product?.productTypeId,
      "price": widget.product?.price?.toString(),
    };
    print("widget.product");
    print(_initalValue);

    initFormData();
  }

  initFormData() async {
    unitOfMeasures = await unitOfMeasureProvider.get();
    productTypes = await productTypeProvider.get();

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Product Details",
      child: Column(
        children: [_buildView(), _buildSaveButton()],
      ),
    );
  }

  Widget _buildSaveButton() {
    return ElevatedButton(
      onPressed: () async {
        formKey.currentState?.saveAndValidate();
        if (formKey.currentState?.validate() ?? false) {
          print(formKey.currentState?.value.toString());
          var request = Map.from(formKey.currentState?.value ?? {});
          if (widget.product == null) {
            widget.product = await productProvider.insert(request);
          } else {
            widget.product =
                await productProvider.update(widget.product!.id, request);
          }
        }
      },
      child: IconButton(
          color: widget.product!.isFavorite == true ? Colors.red : Colors.black,
          onPressed: () async {
            print(AuthProvider.username);
            await favoriteProvider.insert({
              "productId": widget.product!.id,
              "username": AuthProvider.username,
              "addedAt": DateTime.now().toIso8601String()
            });
            Navigator.of(context)
                .push(MaterialPageRoute(builder: (context) => FavoriteList()));
          },
          icon: Icon(Icons.favorite)),
    );
  }

  File? _image;
  String? _base64Image;

  Widget _buildView() {
    if (isLoading) {
      return Center(child: CircularProgressIndicator());
    }

    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: Center(
        child: Column(
          children: [
            Container(
              height: 100,
              width: 100,
              child: widget.product!.assets.firstOrNull == null
                  ? Placeholder()
                  : imageFromString(widget.product!.assets.first.base64Content),
            ),
            Text(widget.product!.name),
            Text(formatNumber(widget.product!.price)),
            Text(unitOfMeasures!
                .items![widget.product!.unitOfMeasureId ?? 0].name),
            Text(productTypes!.items![widget.product!.productTypeId ?? 0].name),
          ],
        ),
      ),
    );
  }
}
