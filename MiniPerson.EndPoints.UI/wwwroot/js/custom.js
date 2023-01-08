window.ShowToastr = (type, message) => {
    if (type === 'success') {
        toastr.success(message);
    }

    if (type === 'error') {
        toastr.error(message);
    }
}
function showConfirmationModal() {
    debugger
    $('#confirmationModal').modal('show');
}
function hideConfirmationModal() {
    $('#confirmationModal').modal('hide');
}