angular.module('vehicleModule').controller('MakeAddController', ['$scope', '$window', MakeAddController]);

function MakeAddController($scope, $window) {

    $scope.AddMake = function () {

        if ($scope.Name == null || $scope.Abrv == null) {
            $window.alert("GREŠKA");
        }
        else {
            var obj = {
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };

            //dsfsf
        }
    };

}