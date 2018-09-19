var app = angular.module("Solicitud", [])
    .controller("SolicitudControlador", function ($scope) {
        $scope.tipo = "";
        $scope.fecha = "";
        $scope.detalle = "";
    });