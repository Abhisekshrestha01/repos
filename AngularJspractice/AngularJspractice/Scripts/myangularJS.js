var myApp = angular.module("myModule", []);

myApp.controller("myController", function ($scope) {
    $scope.message = [
        { name: 'Jani', country: [ 'Norway','Sweden'] },
        { name: 'Carl', country: ['Sweden','England'] },
        { name: 'Margareth', country: ['England','Norway'] }
        
    ];
    $scope.orderByMe = function (x) {
        $scope.myOrderBy = x;
    }
});