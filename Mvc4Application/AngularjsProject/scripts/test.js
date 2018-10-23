/// <reference path="angular.min.js" />
var myapp = angular.module("myModule", []);

var myController = function ($scope) {
    $scope.Message = "I am doing testing.";
}

myapp.controller("test1", myController);

myapp.value("channel", [{
    name: "Arduino",
    type: "Device",
    status: "Active",
    imgpath: "/images/1.png"
}, {
    name: "Fitbit",
    type: "Device",
    status: "Active",
    imgpath: "/images/2.png"
}, {
    name: "MySQL",
    type: "Database",
    status: "Active",
    imgpath: "/images/3.png"
}]);
var myChannelController = function ($scope, channel) {



    $scope.Message = channel;

    $scope.ChangeStatus = function (chn) {
        if (chn.status == "Active") {
            chn.status = "Inactive";
        }
        else {
            chn.status = "Active";

        }
    }
}

myapp.controller("test", myChannelController);


var myChannels = function ($scope) {
    var channel= [{
        name: "Arduino",
        type: "Device",
        status: "Active",
        LaunchDate:new Date("Jan 23, 2000"),
        ProductPrice:5000,
        imgpath: "/images/1.png"
    }, {
        name: "MySQL",
        type: "Database",
        status: "Active",
        LaunchDate: new Date("December 12, 1980"),
        ProductPrice: 6060,
        imgpath: "/images/3.png"
    }, {
        name: "Fitbit",
        type: "Device",
        status: "Active",
        LaunchDate: new Date("March 16, 2010"),
        ProductPrice: 5500,
        imgpath: "/images/2.png"
    }]


    $scope.Message = channel;

    $scope.sortcolumn = "name";
    $scope.rowlimit = 2;
    $scope.ChangeStatus = function (chn) {
        if (chn.status == "Active") {
            chn.status = "Inactive";
            
        }
        else {
            chn.status = "Active";

        }
    }
}

myapp.controller("Channels", myChannels);

var myAPIChannels = function ($scope,$http) {
    $http("api.asmx/GetChannel").then(function(response)
    {
        $scope.Message = response.data;
    })
   

    $scope.sortcolumn = "name";
    $scope.rowlimit = 2;
    $scope.ChangeStatus = function (chn) {
        if (chn.status == "Active") {
            chn.status = "Inactive";

        }
        else {
            chn.status = "Active";

        }
    }
}

myapp.controller("APIChannels", myAPIChannels);