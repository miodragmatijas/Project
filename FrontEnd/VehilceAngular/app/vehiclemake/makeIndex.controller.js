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

    //ubaceno
    $scope.itemsPerPage = 5;
    $scope.currentPage = 0;

    $scope.range = function () {
        var rangeSize = 4;
        var ps = [];
        var start;

        start = $scope.currentPage;
        if (start > $scope.pageCount() - rangeSize) {
            start = $scope.pageCount() - rangeSize + 1;
        }
        for (var i = start; i < start + rangeSize; i++) {
            ps.push(i);
        }
        return ps;
    };
    $scope.prevPage = function () {
        if ($scope.currentPage > 0) {
            $scope.currentPage--;
        }
        getVehicle();
    };
    $scope.DisablePrevPage = function () {
        return $scope.currentPage === 0 ? "disabled" : "";
    };
    $scope.pageCount = function () {
        return Math.ceil(vm.countData / $scope.itemsPerPage) - 1;
    };
    $scope.nextPage = function () {
        if ($scope.currentPage < $scope.pageCount()) {
            $scope.currentPage++;
        }
        getVehicle();
    };
    $scope.DisableNextPage = function () {
        return $scope.currentPage === $scope.pageCount() ? "disabled" : "";
    };
    $scope.setPage = function (n) {
        $scope.currentPage = n;
        getVehicle();
    };

    $scope.sort = function (sortBy) {
        if (sortBy === $scope.sortBy) {
            $scope.reverse = !$scope.reverse;
        } else {
            $scope.sortBy = sortBy;
            $scope.reverse = false;
        }
        if ($scope.reverse == true) { $scope.sortBy = $scope.sortBy + "_desc" };
        $scope.currentPage = 0;
        getVehicle();
    };

    function getVehicle() {

        var pageIndex = $scope.currentPage; //kreće od nule
        var pageSize = $scope.itemsPerPage;  //5; //pageSize
        var txtSearch = ""; //search
        var txtSort = $scope.sortBy; //sort

        return dataservice.getVehicle(pageIndex, pageSize, txtSearch, txtSort)
            .then(function (data) {
                vm.vehicle = data.VehicleMakeView;
                vm.countData = data.CountData;
                vm.itemsPerPage = pageSize;
                return vm.vehicle;
            });
    }
}