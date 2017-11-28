angular
    .module('app')
    .controller('MakeAddController', MakeAddController);

MakeAddController.$inject = ['$scope', 'dataservice', '$window', '$location'];

function MakeAddController($scope, dataservice, $window, $location) {

    $scope.addMake = function () {

        var obj = {
            Name: $scope.Name,
            Abrv: $scope.Abrv
        };

        addVehicle();

        function addVehicle() {
            return dataservice.addVehicle(obj)
                .then(function () {
                    $window.alert("Success Add new Item!");
                    $location.path("/vehicleMake");
                });
        }
    };
}