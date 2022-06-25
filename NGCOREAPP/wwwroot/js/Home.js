var app = angular.module("APP", []);
app.controller("HomeController", function ($scope, $http) {

    $scope.AddUser = function () { 
    $http({
        method: "POST",
        headers: { "Content-Type": "Application/json; charset=utf-8" },
        url: "/Home/Add",
        data: $scope.user,
    }).then(function (result) {



    });

}


});