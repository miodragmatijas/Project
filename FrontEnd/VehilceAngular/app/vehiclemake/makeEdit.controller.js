angular
    .module('app')
    .controller('MakeEditController', MakeEditController);

MakeEditController.$inject = ['dataservice', '$scope', '$routeParams', '$window', '$location'];


function MakeEditController(dataservice, $scope, $routeParams, $window, $location) {

    var vm = this;
    vm.ID = '';
    vm.Name = '';
    vm.Abrv = '';

    $scope.Name = '';
    $scope.Abrv = '';
    

    getVehicleId();

    function getVehicleId() {

        return dataservice.getVehicleId($routeParams.ID)
            .then(function (data) {
                vm.ID = data.ID;
                //vm.Name = data.Name;
                //vm.Abrv = data.Abrv;
                $scope.Name = data.Name;
                $scope.Abrv = data.Abrv;
                return vm;
            });
    }

    

    $scope.update = function () {

      


        updateVehicle();

        function updateVehicle() {

           
            var obj = {
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };

            return dataservice.updateVehicleId($routeParams.ID, obj)
            .then(function () {
                msg = "Item " + $routeParams.ID + " is Updated!!!";
                $window.alert(msg);
                $location.path("/vehicleMake");
                var q = 1;
            });
        }
    };

}