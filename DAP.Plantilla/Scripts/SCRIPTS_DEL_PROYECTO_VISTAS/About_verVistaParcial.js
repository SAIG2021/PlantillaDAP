






$(document).ready(function () {








/*************************************************************************************************************************************************************************************************/
/**************************************************************************************************************************************************************************************************/
/******************************************************************   VISTA PRINCIPAL DE ABOUT    *************************************************************************************************/

    const verVista = document.getElementById("verVistaParcial");
    verVista.addEventListener("click",
        function () {

            MensajeCargando();
            $.ajax({
                url: '/home/verVistaParcial',
                type: "GET",
                contentType: "application/json; charset=utf-8",
                success: function (response) {

                    if (response.RespuestaServidor === "500") {
                        MensajeErrorSweet(response.MensajeError);
                        $('#RenderVistaParcial').html('');
                    } else {
                        $('#RenderVistaParcial').html('');
                        $('#RenderVistaParcial').html(response);

                    }

                    OcultarMensajeCargando();
                }
            });





        }
    );






/*************************************************************************************************************************************************************************************************/
/**************************************************************************************************************************************************************************************************/
/******************************************************************   FIN PRINCIPAL DE ABOUT    *************************************************************************************************/








   
















});








// ver Alumnos en materias //
function DibujarTblAlumnos() {
    $("#divTblAlumnos").append(

        "<table id='TblAlumnos'  class='margenSection table table-striped display table-bordered table-hover' cellspacing='0'  style='width:100%'>" +
        " <caption class='text-uppercase'>Alumnos en Materia selecionada</caption>"
        + "<thead class='tabla'>" +

        "<tr class='text-center text-uppercase'>" +


        "<th> Id </th>" +
        "<th> Matematicas </th>" +
        "<th> Nombre </th>" +
        "<th> Apelllido Paterno </th>" +
        "<th> Apelllido Materno </th>" +
        "<th> Edad </th>" +
        "<th> Activo </th>" +
        "<th id='pruebaID'> Especialidad </th>" +

        "</tr>" +
        "</thead>" +
        "</table>"
    );
};

let RegistrosTabla;
function PintarDatosTblAlumnos(datos) {
    RegistrosTabla = $('#TblAlumnos').DataTable({
        "ordering": true,
        "info": false,
        "searching": false,
        "paging": false,
        "lengthMenu": [5, 10],
        "language":
        {
            "processing": "Procesando...",
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "emptyTable": "Ningún dato disponible en esta tabla",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "search": "Buscar:",
            "info": "Mostrando de _START_ a _END_ de _TOTAL_ entradas",
            "paginate": {
                "first": "Primero",
                "last": "Último",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        "data": datos,
        "columns": [

            { "data": "IdVirtual" },
            { "data": "Materia" },
            { "data": "NombreAlumno" },
            { "data": "APaternoAlumno" },
            { "data": "AMaternoAlumno" },
            { "data": "Edad" },
            { "data": "ActivoAlumno" }

        ],
        "columnDefs": [

            { className: "text-center col-2", visible: true, "targets": 0, },
            { className: "text-center col-2", visible: true, "targets": 1, },
            { className: "text-center col-2", visible: true, "targets": 2, },
            { className: "text-center col-2", visible: true, "targets": 3, },
            { className: "text-center col-1", visible: true, "targets": 5, },
            { className: "text-center col-1", visible: true, "targets": 6, },
            {
                className: "text-center col-1",
                visible: true,
                "targets": [7],
                render: function (data, type, row) {
                    return '<h4 class="verEspecialidad bg-success btn  text-uppercase text-light"> Ver Especialidad </h4>';
                }
            }



        ],
        "order": [[0, 'desc']]

    });

};

/***********************************************************************************************************************************************************************************************/



// ver Especialidad de materia//
function DibujarTblEspecialidad() {
    $("#divTblEspecialidad").append(

        "<table id='TblEspecialidad'  class='margenSection table table-striped display table-bordered table-hover' cellspacing='0'  style='width:100%'>" +
        " <caption class='text-uppercase'>Especialidad de materia seleccionada</caption>"
        + "<thead class='tabla'>" +

        "<tr class='text-center text-uppercase'>" +


        "<th> Id </th>" +
        "<th> Especialidad</th>" +
        "<th> Tiene Titulo </th>" +
        "<th> Tiene Certificado Tecnico </th>" +
        "<th> AÑos Activos </th>" +
        "<th> Activo </th>" +

        "</tr>" +
        "</thead>" +
        "</table>"
    );
};


function PintarDatosTblEspecialidad(datos) {
    $('#TblEspecialidad').DataTable({
        "ordering": true,
        "info": false,
        "searching": false,
        "paging": false,
        "lengthMenu": [5, 10],
        "language":
        {
            "processing": "Procesando...",
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "emptyTable": "Ningún dato disponible en esta tabla",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "search": "Buscar:",
            "info": "Mostrando de _START_ a _END_ de _TOTAL_ entradas",
            "paginate": {
                "first": "Primero",
                "last": "Último",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        "data": datos,
        "columns": [

            { "data": "IdVirtual" },
            { "data": "Especialidad" },
            { "data": "Titulo" },
            { "data": "Tecnico" },
            { "data": "AniosActivo" },
            { "data": "Activo" }

        ],
        "columnDefs": [

            { className: "text-center col-1", visible: true, "targets": 0, },
            { className: "text-center col-6", visible: true, "targets": 1, },
            { className: "text-center col-2", visible: true, "targets": 2, },
            { className: "text-center col-2", visible: true, "targets": 3, },
            { className: "text-center col-1", visible: true, "targets": 5, }

        ],
        "order": [[0, 'desc']]

    });

};








async function PetionAXIOS(cadenaPath) {

    console.log(cadenaPath);

    //const response = await axios.post(cadenaPath, { IdMateria: opcionSeleccionado.value });
    const response = await axios.post(cadenaPath);


    if (response.status == 200) {

        alert(response.data.VariableKey);
    }


}



function BuscarMateria()
{

    let ItemSeleccionado = document.getElementById("IdEjemplo").value
   
 
    if (ItemSeleccionado != "") {


        MensajeCargando();

        let buscarIdMateria = "{'IdMateria':'"+ItemSeleccionado+"'}";

        console.log(buscarIdMateria)
        $.ajax({
            url: 'ObtenerAlumnos',
            data: buscarIdMateria,
            type: "POST",
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                console.log(response.ListaEjemplo)

                $('#divTblAlumnos').empty();
                DibujarTblAlumnos();
                PintarDatosTblAlumnos(response.ListaEjemplo);

                //OCULTAR EL MODAL DONDE SE ENCUENTRA LA VISTA PARCIAL
                $('#PruebaModal').modal('show');


                OcultarMensajeCargando();

            }, error: function (jqXHR, textStatus) {
                MensajeErrorSweet("Ocurrio un error intente de nuevo " + textStatus)
                OcultarMensajeCargando();
            }
        });


    } else {
        MensajeErrorSweet("Seleccione una materia", "No Selecciono ninguna opcion");
    }






}




$(document).on("click", ".verEspecialidad", function () {

    // Decomentar para volver al funcionamiendo original

    let datoIdbuscar = RegistrosTabla.row($(this).parents("tr")).data();

    console.log(datoIdbuscar.IdMateria);

    MensajeCargando();
    let buscarEspecialidadIdMateria = "{'IdMateria':'" + datoIdbuscar.IdMateria + "'}";

    $.ajax({
        url: 'ObtenerEspecialidadIdMateria',
        data: buscarEspecialidadIdMateria,
        type: "POST",
        contentType: "application/json; charset=utf-8",
        success: function (response) {

            console.log(response.ListaEjemplo)

            $('#divTblEspecialidad').empty();
            DibujarTblEspecialidad()
            PintarDatosTblEspecialidad(response.ListaEjemplo);

            //OCULTAR EL MODAL DONDE SE ENCUENTRA LA VISTA PARCIAL
            $('#VerEspecialidad').modal('show');


            OcultarMensajeCargando();

        }, error: function (jqXHR, textStatus) {
            MensajeErrorSweet("Ocurrio un error intente de nuevo " + textStatus)
            OcultarMensajeCargando();
        }
    });


});






