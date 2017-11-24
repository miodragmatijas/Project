vehicleModule.controller('MakeAddController', function ($scope, $window, $http) {


    $scope.AddMake = function () {
        if ($scope.Name == null || $scope.Abrv == null) {
            $window.alert("GREŠKA");
        }
        else {
            var obj = {
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };
        }

        $http.post('http://localhost:64407/api/vehicle/', obj).success(function (data) {
            $scope.response = data;
            console.log(data);
            $window.alert("Success");
        });
    };
});

