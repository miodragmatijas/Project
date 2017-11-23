vehicleModule.controller('MakeDetailsController', function ($scope,$location) {

    $scope.id = toString;

    $scope.detailsVehicle = function (dat) {

        toString = dat.toString();
        $location.path('/MakeDetails');
    };

});
   


