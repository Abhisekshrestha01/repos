/// <reference path="angular.min.js" />

var myapp = angular.module("CustomerModule", ["ngRoute"])
        .config(function ($routeProvider) {
            $routeProvider.when("/customer", {
                controller: "supplier",
                templateURL: "View/supplier.html"
            })
            .when("/product", {
                controller: "Product",
                templateURL: "View/Product.html"
            })
           
        })
    .controller("Supplier", function ($scope, $http) {
        $http.get("api.asmx/GetSupplier").then(function (response)
        {
            $scope.Message = response.data;
        })
    })
 .controller("Product", function ($scope, $http) {
     $http.get("api.asmx/GeProduct").then(function (response) {
         $scope.Message = response.data;
     })
 })