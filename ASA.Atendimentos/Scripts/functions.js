$(document).ready(function () {
    $('#dataTables-example').DataTable({
        responsive: true,
        "pagingType": "full_numbers"
    });

    //Accordion
    var acc = document.getElementsByClassName("accordion");
    var i;

    for (i = 0; i < acc.length; i++) {
        acc[i].onclick = function () {
            this.classList.toggle("active");
            this.nextElementSibling.classList.toggle("show");
        }
    }
    //Fim

    $.ajax({
        // your ajax code
        beforeSend: function () {
            $('.loader').show()
        },
        complete: function () {
            $('.loader').hide()
        }
    });

    //$('form').validator();

})

function CallModal() {
    $('#modal-title').html('Atenção!');
    $('#modal-body').html('Aqui está o modal bootstrap');
    $('#myModal').modal();
}