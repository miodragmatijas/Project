angular
    .module('app')
    .factory('dataservice', dataservice);

dataservice.$inject = ['$http'];

function dataservice($http) {
    return {
        getVehicle: getVehicle
    };

    function getVehicle() {
        return $http.get('http://localhost:64407/api/vehicle')
            .then(getVehicleComplete)
            .catch(getVehicleFailed);

        function getVehicleComplete(response) {
            return response.data;
        }

        function getVehicleFailed(error) {
            //logger.error('Error' + error.data);
        }

    }


}

