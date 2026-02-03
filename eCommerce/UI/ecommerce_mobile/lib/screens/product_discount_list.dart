import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/product_discount.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/product_discount_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

class ProductDiscountList extends StatefulWidget {
  const ProductDiscountList({super.key});

  @override
  State<ProductDiscountList> createState() => _ProductDiscountListState();
}

class _ProductDiscountListState extends State<ProductDiscountList> {
  late ProductDiscountProvider productDiscountProvider;
  TextEditingController searchController = TextEditingController();
  num? totalPrice;
  num? saved;
  SearchResult<ProductDiscount>? data;

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
  }

  @override
  void initState() {
    super.initState();
    productDiscountProvider = context.read<ProductDiscountProvider>();
    loadData();
  }

  void loadData() async {
    var productDiscounts = await productDiscountProvider.get(filter: {
      "fts": "",
    });
    this.data = productDiscounts;
    num calculatedTotalPrice = 0;
    num calculatedSaved = 0;
    if (productDiscounts.items != null) {
      for (var item in productDiscounts.items!) {
        num oldPrice = item.product!.price!;
        num newPrice = oldPrice * (1 - item.discount);
        calculatedTotalPrice += newPrice;
        calculatedSaved += (oldPrice - newPrice);
      }
    }

    setState(() {
      this.totalPrice = calculatedTotalPrice;
      this.saved = calculatedSaved;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
        title: "Product Discount",
        child: Center(
          child: Column(
            children: [_buildSearch(), _buildList(), _buildTotals()],
          ),
        ));
  }

  Widget _buildList() {
    return Expanded(
      child: Container(
        width: double.infinity,
        child: SingleChildScrollView(
          child: Container(
            height: 700,
            child: GridView(
              gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                  crossAxisCount: 2,
                  childAspectRatio: 4 / 3,
                  crossAxisSpacing: 10,
                  mainAxisSpacing: 30),
              scrollDirection: Axis.horizontal,
              children: _buildProductDiscountCardList(),
            ),
          ),
        ),
      ),
    );
  }

  List<Widget> _buildProductDiscountCardList() {
    if (data == null || data?.items?.length == 0) {
      return [Text("Loading...")];
    }

    List<Widget> list = data!.items!
        .map((x) => Container(
              child: Column(
                children: [
                  Container(
                    height: 100,
                    width: 100,
                    child: x.product!.assets.firstOrNull == null
                        ? Placeholder()
                        : imageFromString(
                            x.product!.assets.first.base64Content),
                  ),
                  Text(x.product!.name),
                  Text(formatNumber(x.product!.price)),
                  Text("Discount:${x.discount * 100}%"),
                  Text(
                      "New price: ${formatNumber(x.product!.price! * (1 - x.discount))}"),
                  Text(
                      "Vazi od ${DateFormat('dd/MM/yyyy').format(x.beganAt!)} do ${DateFormat('dd/MM/yyyy').format(x.validUntil!)}"),
                  IconButton(
                      onPressed: () {
                        productDiscountProvider.update(x.id, {
                          'productId': x.productId,
                          'discount': 0,
                          'beganAt': x.beganAt!.toIso8601String(),
                          'validUntil': x.validUntil!.toIso8601String()
                        });
                        loadData();
                      },
                      icon: Icon(Icons.delete))
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }

  Widget _buildSearch() {
    return Padding(
        padding: EdgeInsets.all(10),
        child: Row(
          children: [
            Expanded(
              child: TextField(
                decoration: InputDecoration(
                  hintText: "Search",
                  border: OutlineInputBorder(),
                ),
                controller: searchController,
              ),
            ),
            SizedBox(width: 10),
            ElevatedButton(
              onPressed: () async {
                var filter = {
                  "fts": searchController.text,
                };
                debugPrint(filter.toString());
                var products =
                    await productDiscountProvider.get(filter: filter);
                // debugPrint(products.items?.firstOrNull?.name);
                this.data = products;
                setState(() {});
              },
              child: Text("Search"),
            ),
            SizedBox(width: 10),
          ],
        ));
  }

  Widget _buildTotals() {
    return Column(
      children: [
        Text("Total price: ${formatNumber(this.totalPrice)}"),
        Text("Saved: ${formatNumber(this.saved)}"),
      ],
    );
  }
}
