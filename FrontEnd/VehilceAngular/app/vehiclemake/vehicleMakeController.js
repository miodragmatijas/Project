app.controller('VehicleMakeController', function ($scope, VehicleMakeService) {
    getAll();

    function getAll() {
        var serviceCall = VehicleMakeService.getSubs();
        serviceCall.then(function (d) {
            $scope.vehicleMake = d.data;
            
            
        }, function (error) {
                $log.error('Fetch error');
            }
        );
    }
});
