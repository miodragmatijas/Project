angular
    .module('app')
    .factory('dataservice', dataservice);

dataservice.$inject = ['$http', 'logger'];

function dataservice($http, logger) {

    var service = {
        getVehicle: getVehicle,
        getVehicleId: getVehicleId,
        deleteVehicleId: deleteVehicleId,
        addVehicle: addVehicle,
        updateVehicleId: updateVehicleId

    };
    return service;

    function getVehicle() {
    
        return $http.get('http://localhost:64407/api/vehicle?'
            + 'pageIndex=' + 1
            + '&pageSize=' + 11
            + '&txtSearch=' + ''
            + '&txtSort=' + 'name_desc')
            .then(getVehicleComplete)
            .catch(getVehicleError);

        function getVehicleComplete(response) {
            var i = 0;
            return response.data.VehicleMakeView;
        }
        function getVehicleError(error) {
            var j = 0;
            logger.error('Error' + error.data);
        }
    }

    function getVehicleId(id) {
        return $http.get('http://localhost:64407/api/vehicle/' + id)
            .then(getVehicleComplete)
            .catch(getVehicleError);
        function getVehicleComplete(response) {
            return response.data;
        }
        function getVehicleError(error) {
            logger.error('Error' + error.data);
        }
    }

    function deleteVehicleId(id) {
        return $http.delete('http://localhost:64407/api/vehicle/' + id)
            .then(getVehicleComplete)
            .catch(getVehicleError);
        function getVehicleComplete(response) {
            return response.data;
        }
        function getVehicleError(error) {
            logger.error('Error' + error.data);
        }
    }

    function addVehicle(obj) {
        return $http.post('http://localhost:64407/api/vehicle/', obj)
            .then(getVehicleComplete)
            .catch(getVehicleError);
        function getVehicleComplete(response) {
            return response.data;
        }
        function getVehicleError(error) {
            logger.error('Error' + error.data);
        }
    }

    function updateVehicleId(id, obj) {
        return $http.put('http://localhost:64407/api/vehicle/' + id, obj)
            .then(getVehicleComplete)
            .catch(getVehicleError);
        function getVehicleComplete(response) {
            return response.data;
        }
        function getVehicleError(error) {
            logger.error('Error' + error.data);
        }
    }


}



