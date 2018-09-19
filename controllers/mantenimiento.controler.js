var app = angular.module("Mantenimiento", [])
    .controller("MantenimientoControlador", function ($scope) {
        $scope.tipo = "";
        $scope.codigo = "";
        $scope.asignado = "";
        $scope.aprobado = "";
    });