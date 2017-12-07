angular
    .module('app')
    .controller('VehicleMakeController', VehicleMakeController);

VehicleMakeController.$inject = ['dataservice', '$scope'];

function VehicleMakeController(dataservice, $scope) {
    var vm = this;
    vm.vehicle = [];

    getVehicle();

    function getVehicle() {
        return dataservice.getVehicle()
            .then(function (data) {
                vm.vehicle = data;
                return vm.vehicle;
            });
    }

    $scope.sort = function (key) {
        $scope.sortKey = key;
        $scope.reverse = !$scope.reverse;
    };
}