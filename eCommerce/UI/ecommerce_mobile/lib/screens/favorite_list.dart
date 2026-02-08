import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/cart_provider.dart';
import 'package:ecommerce_mobile/model/favorite.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/auth_provider.dart';
import 'package:ecommerce_mobile/providers/favorite_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/product_details_screen.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';

class FavoriteList extends StatefulWidget {
  const FavoriteList({super.key});

  @override
  State<FavoriteList> createState() => _FavoriteListState();
}

class _FavoriteListState extends State<FavoriteList> {
  late FavoriteProvider favoriteProvider;
  late CartProvider cartProvider;
  late AuthProvider authProvider;

  late DateTime? from = null;
  late DateTime? to = null;

  SearchResult<FavoriteIB200116>? data;

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
  }

  @override
  void initState() {
    super.initState();
    favoriteProvider = context.read<FavoriteProvider>();
    authProvider = context.read<AuthProvider>();
    cartProvider = context.read<CartProvider>();
    loadData();
  }

  void loadData() async {
    var favoriteProducts = await favoriteProvider.get(filter: {
      "code": "",
      "fts": "",
      'from': this.from?.toIso8601String(),
      'to': this.to?.toIso8601String(),
      'username': AuthProvider.username
    });
    print(AuthProvider.username);
    this.data = favoriteProducts;
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Favorite List",
      child: Center(
        child: Column(
          children: [_buildSearch(context), _buildResultView()],
        ),
      ),
    );
  }

  Widget _buildSearch(context) {
    return Padding(
        padding: EdgeInsets.all(10),
        child: Row(
          children: [
            SizedBox(width: 10),
            ElevatedButton(
                onPressed: () async {
                  var from = await showDatePicker(
                      context: context,
                      firstDate: DateTime.now(),
                      lastDate: DateTime.now().add(Duration(days: 365)));
                  setState(() {
                    this.from = from;
                  });
                },
                child: Text(
                    "OD:${from != null ? DateFormat('dd/MM/yyyy').format(from!) : ''}")),
            ElevatedButton(
                onPressed: () async {
                  var to = await showDatePicker(
                      context: context,
                      firstDate: DateTime.now(),
                      lastDate: DateTime.now().add(Duration(days: 364)));
                  setState(() {
                    this.to = to;
                  });
                },
                child: Text(
                    "DO:${to != null ? DateFormat('dd/MM/yyyy').format(to!) : ''}")),
            ElevatedButton(
                onPressed: () async {
                  if (this.from == null || this.to == null) {
                    await showDialog(
                        context: context,
                        builder: (context) => AlertDialog(
                              title: Text("Error"),
                              actions: [
                                TextButton(
                                    onPressed: () => Navigator.pop(context),
                                    child: Text("OK"))
                              ],
                              content: Text("Pleas select dates"),
                            ));
                  }
                  loadData();
                },
                child: Text("Search")),
            SizedBox(width: 10),
          ],
        ));
  }

  Widget _buildResultView() {
    return Expanded(
        child: Container(
      width: double.infinity,
      child: SingleChildScrollView(
        child: Container(
          height: 500,
          child: GridView(
            gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                crossAxisCount: 2,
                childAspectRatio: 4 / 3,
                crossAxisSpacing: 10,
                mainAxisSpacing: 30),
            scrollDirection: Axis.horizontal,
            children: _buildProductCardList(),
          ),
        ),
      ),
    ));
  }

  List<Widget> _buildProductCardList() {
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
                    child: x.product?.assets.firstOrNull == null
                        ? Placeholder()
                        : imageFromString(
                            x.product!.assets.first.base64Content),
                  ),
                  Text(x.product!.name),
                  Text(formatNumber(x.product?.price)),
                  Text(
                      textAlign: TextAlign.center,
                      "Added to favorite: ${DateFormat('dd/MM/yyyy').format(x.addedAt!)}"),
                  IconButton(
                      onPressed: () {
                        cartProvider?.addToCart(x.product!);
                      },
                      icon: Icon(Icons.shopping_cart))
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
