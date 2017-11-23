vehicleModule.controller('VehicleMakeController', function ($scope, $http,$location) {

    $http.get('http://localhost:64407/api/vehicle')
        .then(function (response) { $scope.vehicleMake = response.data; });

});