angular
    .module('app')
    .controller('VehicleMakeController', VehicleMakeController);

VehicleMakeController.$inject = ['dataservice'];

function VehicleMakeController(dataservice) {
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
}