angular.module('vehicleModule').controller('MakeDetailsController', ['$scope', MakeDetailsController]);

function MakeDetailsController($scope) {

    $scope.detailsVehicle = function (k) {
        var i = k;
        $scope.message = i;
    };
}


