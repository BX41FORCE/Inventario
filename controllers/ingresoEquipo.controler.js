var app = angular.module("IngresoEquipo", [])
    .controller("IngresoEquipoControlador", function ($scope) {
        $scope.tipo = "";
        $scope.numero = "";
        $scope.codigoInterno = "";
        $scope.ciduad = "";
        $scope.responsable = "";
        $scope.descripcion = "";
        $scope.memoriaRam = "";
        $scope.procesador = "";
        $scope.discoDuro = "";
        $scope.sistemaOperativo = "";
        $scope.licenciado = "";
        $scope.office = "";
        $scope.marca = "";
        $scope.modelo = "";
        $scope.serie = "";
        $scope.particularidad = "";
        $scope.numeroFactura = "";
        $scope.valorFactura = "";
        $scope.fechaAdquisición = "";
        $scope.observaciones = "";
    });