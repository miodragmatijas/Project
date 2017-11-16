app.service("VehicleMakeService", function ($http) {
    this.getSubs = function () {
        return $http.get('http://localhost:64407/api/vehicle');
    };
});

