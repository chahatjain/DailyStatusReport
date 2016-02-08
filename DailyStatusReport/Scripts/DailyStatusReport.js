function nameDropDown() {
    $('#nameDropDown li > a').click(function () {
        $('#devName').val($(this).text());
    });
}
function projectDropDown() {
    $('#projectDropDown li > a').click(function () {
        $('#project').val($(this).text());
    });
}
function fixVersionDropDown() {
    $('#fixVersionDropDown li > a').click(function () {
        $('#fixVersion').val($(this).text());
    });
}
function statusDropDown() {
    $('#statusDropDown li > a').click(function () {
        $('#status').val($(this).text());
    });
}

function SaveDetails() {
    var devName = $("#devName").val();
    var project = $("#project").val();
    var fixVersion = $("#fixVersion").val();
    var ticketStatus = $("#status").val();
    var ticketNumber = $("#ticketNumber").val();
    var ticketDescription = $("#ticketDesc").val();
    var codeReviewId = $("#codeReviewId").val();
    var remark = $("#remark").val();
    var blocker = $("#blocker").val();

    $.ajax({
        type: 'POST',
        url: "/Report/SaveDetails",
        data: JSON.stringify({
                            "devName": devName, "fixVersion": fixVersion, "project": project, "ticketNumber": ticketNumber, "ticketDescription": ticketDescription,
                            "ticketStatus": ticketStatus, "codeReviewId": codeReviewId, "remark": remark, "blocker": blocker
        }),
        dataType: 'text',
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            alert("Report is Saved");
        },
        error: function (ex) {
            alert("Report is not saved");
        }
    });

}