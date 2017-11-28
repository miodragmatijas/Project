angular
    .module('app')
    .controller('MakeDeleteController', MakeDeleteController);

MakeDeleteController.$inject = ['dataservice', '$scope', '$routeParams', '$window','$location'];

function MakeDeleteController(dataservice, $scope, $routeParams, $window, $location) {

    $scope.makeDelete = function () {

        deleteVehicle();

        function deleteVehicle() {
            return dataservice.deleteVehicleId($routeParams.ID)
                .then(function (data) {
                    msg = "Item " + $routeParams.ID + " is Deleted!!!";
                    $window.alert(msg);
                    $location.path("/vehicleMake");
                });
        }
    };
}