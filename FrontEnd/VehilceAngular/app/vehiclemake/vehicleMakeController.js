app.controller('VehicleMakeController', function ($scope, $http) {
    $http.get('http://localhost:64407/api/vehicle')
        .then(function (response) { $scope.vehicleMake = response.data; });
});