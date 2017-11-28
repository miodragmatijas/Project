angular
    .module('app')
    .controller('MakeDetailsController', MakeDetailsController);

MakeDetailsController.$inject = ['dataservice', '$scope', '$routeParams'];

function MakeDetailsController(dataservice, $scope, $routeParams) {
    var vm = this;
    vm.ID = '';
    vm.Name = '';
    vm.Abrv = '';


    getVehicleId();

    function getVehicleId() {
        
        return dataservice.getVehicleId($routeParams.ID)
            .then(function (data) {
                vm.ID = data.ID;
                vm.Name = data.Name;
                vm.Abrv = data.Abrv;
                return vm;
            });
    }

    //$scope.makeDelete = function (xx) {

    //    $http.delete('http://localhost:64407/api/vehicle/' + $routeParams.ID)

    //        .then(function () {
    //            msg = "Item " + xx + " is Deleted!!!";
    //            $window.alert(msg);
    //            $location.path("vehicleMake");
    //        });
    //};

}



