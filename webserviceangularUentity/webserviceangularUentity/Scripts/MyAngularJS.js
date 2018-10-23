var app = angular.module("myApp", []);
app.controller("myController", function ($scope,$http) {
    $http.get("C:\Users\shres\source\repos\webserviceangularUentity\webserviceangularUentity\EmployeeServices.asmx\GetEmployee")
        .then(function (response) {
            $scope.employees = response.data; 
        });
    });