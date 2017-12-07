angular
    .module('app')
    .controller('MakeEditController', MakeEditController);

MakeEditController.$inject = ['dataservice', '$scope', '$routeParams', '$window', '$location'];

function MakeEditController(dataservice, $scope, $routeParams, $window, $location) {

    $scope.Name = '';
    $scope.Abrv = '';
    $scope.ID = '';    

    getVehicleId();

    function getVehicleId() {

        return dataservice.getVehicleId($routeParams.ID)
            .then(function (data) {
                $scope.ID = data.ID;
                $scope.Name = data.Name;
                $scope.Abrv = data.Abrv;
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