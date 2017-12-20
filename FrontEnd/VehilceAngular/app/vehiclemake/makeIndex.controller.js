angular
    .module('app')
    .controller('VehicleMakeController', VehicleMakeController);

VehicleMakeController.$inject = ['dataservice', '$scope'];

function VehicleMakeController(dataservice, $scope) {
    var vm = this;
    vm.vehicle = [];
    vm.countData = 1;
    vm.pageIndex = 0;

    getVehicle();

    function getVehicle() {

        var pageIndex = 0; //kreće od nule
        var pageSize = 10; //pageSize
        var txtSearch = "";
        var txtSort = "name";

        $scope.search = function () {
            $scope.pagingInfo.page = 1;
            loadUsers();
        };


        $scope.search = function () {
            $scope.pagingInfo.page = 1;
            loadUsers();
        };

        $scope.sort = function (sortBy) {
            if (sortBy === $scope.pagingInfo.sortBy) {
                $scope.pagingInfo.reverse = !$scope.pagingInfo.reverse;
            } else {
                $scope.pagingInfo.sortBy = sortBy;
                $scope.pagingInfo.reverse = false;
            }
            $scope.pagingInfo.page = 1;
            loadUsers();
        };

        $scope.pageChanged = function (page) {
            $scope.pagingInfo.page = page;
            loadUsers();
        };



        $scope.pagination = { current: 1 };



        return dataservice.getVehicle(pageIndex, pageSize, txtSearch, txtSort)
            .then(function (data) {
                vm.vehicle = data.VehicleMakeView;
                vm.countData = data.CountData;
                vm.itemsPerPage = pageSize;
                return vm.vehicle;
            });


    }
}