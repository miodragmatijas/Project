angular
    .module('app')
    .controller('VehicleMakeController', VehicleMakeController);

VehicleMakeController.$inject = ['dataservice', '$scope'];

function VehicleMakeController(dataservice, $scope) {
    var vm = this;
    vm.vehicle = [];
    vm.countData = 1;

    getVehicle();

    function getVehicle() {

        var pageIndex = 0; //kreće od nule
        var pageSize = 10;
        var txtSearch = "";
        var txtSort = "name";

        return dataservice.getVehicle(pageIndex, pageSize, txtSearch, txtSort)
            .then(function (data) {
                vm.vehicle = data.VehicleMakeView;
                vm.countData = data.CountData;
                return vm.vehicle;
            });
    }
}