import 'dart:convert';
import 'dart:io';

import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/product_discount.dart';
import 'package:ecommerce_mobile/model/product_type.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/unit_of_measure.dart';
import 'package:ecommerce_mobile/providers/product_discount_provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';
import 'package:ecommerce_mobile/providers/product_type_provider.dart';
import 'package:ecommerce_mobile/providers/unit_of_measure_provider.dart';
import 'package:ecommerce_mobile/screens/product_discount_list.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
// import 'package:file_picker/file_picker.dart';

class ProductDiscountDetailsScreen extends StatefulWidget {
  ProductDiscount? productDiscount;
  ProductDiscountDetailsScreen({super.key, this.productDiscount});

  @override
  State<ProductDiscountDetailsScreen> createState() =>
      _ProductDiscountDetailsScreenState();
}

class _ProductDiscountDetailsScreenState
    extends State<ProductDiscountDetailsScreen> {
  final formKey = GlobalKey<FormBuilderState>();

  Map<String, dynamic> _initalValue = {};

  late ProductDiscountProvider productDiscountProvider;
  late ProductProvider productProvider;

  SearchResult<Product>? product;

  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    productDiscountProvider =
        Provider.of<ProductDiscountProvider>(context, listen: false);
    productProvider = Provider.of<ProductProvider>(context, listen: false);
    _initalValue = {
      "productId": widget.productDiscount?.product?.id,
      "discount": widget.productDiscount?.discount,
      "beganAt": widget.productDiscount?.beganAt,
      "validUntil": widget.productDiscount?.validUntil,
    };
    print("widget.product");
    print(_initalValue);

    initFormData();
  }

  initFormData() async {
    product = await productProvider.get();
    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Product Discount Details",
      child: Column(
        children: [_buildForm(), _buildSaveButton()],
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
          request['beganAt'] =
              (request['beganAt'] as DateTime).toIso8601String();
          request['validUntil'] =
              (request['validUntil'] as DateTime).toIso8601String();
          if (request['discount'] != null) {
            double discount = double.parse(request['discount']);
            request['discount'] = discount / 100;
          }

          if (widget.productDiscount == null) {
            widget.productDiscount =
                await productDiscountProvider.insert(request);
            Navigator.of(context).push(
                MaterialPageRoute(builder: (context) => ProductDiscountList()));
          } else {
            widget.productDiscount = await productDiscountProvider.update(
                widget.productDiscount!.id, request);
            Navigator.of(context).push(
                MaterialPageRoute(builder: (context) => ProductDiscountList()));
          }
        }
      },
      child: Text("Save"),
    );
  }

  File? _image;
  String? _base64Image;

  Widget _buildForm() {
    if (isLoading) {
      return Center(child: CircularProgressIndicator());
    }

    return FormBuilder(
        key: formKey,
        initialValue: _initalValue,
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            children: [
              FormBuilderDropdown(
                name: "productId",
                items: product?.items
                        ?.map((e) =>
                            DropdownMenuItem(value: e.id, child: Text(e.name)))
                        .toList() ??
                    [],
                validator: (value) {
                  if (value == null) {
                    return "Pleas select product";
                  }
                  return null;
                },
              ),
              FormBuilderTextField(
                name: "discount",
                decoration: InputDecoration(labelText: "discount"),
                keyboardType: TextInputType.numberWithOptions(decimal: true),
                valueTransformer: (text) {
                  text != null ? double.tryParse(text) : null;
                },
                initialValue: widget.productDiscount?.product?.id?.toString(),
                validator: (value) {
                  if (value == null) {
                    return "Pleas insert discount";
                  }
                  double? discount = double.tryParse(value);
                  if (discount == null || discount < 0 || discount > 100) {
                    return "Discount must be between 0 and 100";
                  }

                  return null;
                },
              ),
              Row(
                children: [
                  Expanded(
                      child: FormBuilderDateTimePicker(
                    name: "beganAt",
                    // initialDate: widget.productDiscount?.beganAt,
                    decoration: InputDecoration(labelText: "Began At"),
                    validator: (value) {
                      if (value == null) return "Please select a start date";

                      final validUntil =
                          formKey.currentState?.fields['validUntil']?.value;
                      if (validUntil != null && value.isAfter(validUntil)) {
                        return "Start date must be before end date";
                      }
                      return null;
                    },
                    onChanged: (value) {
                      // Revalidate validUntil when beganAt changes
                      formKey.currentState?.fields['validUntil']?.validate();
                    },
                  )),
                  SizedBox(
                    width: 10,
                  ),
                  Expanded(
                      child: FormBuilderDateTimePicker(
                    name: "validUntil",
                    // initialDate: widget.productDiscount?.validUntil,
                    decoration: InputDecoration(labelText: "Valid until"),
                    validator: (value) {
                      if (value == null) return "Please select a start date";

                      final beganAt =
                          formKey.currentState?.fields['beganAt']?.value;
                      if (beganAt != null && value.isBefore(beganAt)) {
                        return "End date must be after start date";
                      }
                      return null;
                    },
                    onChanged: (value) {
                      // Revalidate beganAt when validUntil changes
                      formKey.currentState?.fields['beganAt']?.validate();
                    },
                  )),
                ],
              ),

              // Row(
              //   children: [
              //     Expanded(
              //         child: FormBuilderField(
              //             name: "image",
              //             builder: (FormFieldState<dynamic> field) {
              //               return TextButton(
              //                 onPressed: () async {
              //                   FilePickerResult? result =
              //                       await FilePicker.platform.pickFiles();
              //                   if (result != null) {
              //                     _image = File(result.files.single.path!);
              //                     _base64Image = base64Encode(_image!.readAsBytesSync());
              //                   }
              //                 },
              //                 child: Text("Upload Image"),
              //               );
              //             }))
              //   ],
              // )
            ],
          ),
        ));
  }
}
