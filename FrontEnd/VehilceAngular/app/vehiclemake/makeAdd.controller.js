angular
    .module('app')
    .controller('MakeAddController', MakeAddController);

function MakeAddController($scope, $window, $http, $location) {

    $scope.AddMake = function () {
        if ($scope.Name == null || $scope.Abrv == null) {
            $window.alert("Error!");
        }
        else {
            var obj = {
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };
        }

        $http.post('http://localhost:64407/api/vehicle/', obj).success(function (data) {
            $scope.response = data;

            $window.alert("Success Add new Item!");
            $location.path("vehicleMake");
        });
    };
}