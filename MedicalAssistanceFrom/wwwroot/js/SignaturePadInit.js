
var signaturePadWrappers = document.querySelectorAll('.signature-pad');


Array.prototype.forEach.call(signaturePadWrappers, function (wrapper) {
    var canvas = wrapper.querySelector('canvas');
    var clearButton = wrapper.querySelector('.btn-clear-canvas');
    var hiddenInput = wrapper.querySelector('input[type="hidden"]');

    var signaturePad = new SignaturePad(canvas);

    var base64str = hiddenInput.value;

    if (base64str) {
        signaturePad.fromDataURL('data:image/png;base64,' + base64str);
    }

    if (hiddenInput.disabled) {
        signaturePad.off();

    }
    else {
        signaturePad.onEnd = function () {
            base64str = signaturePad.toDataURL().split(',')[1];
            hiddenInput.value = base64str;
        };

        clearButton.addEventListener('click', function () {
            signaturePad.clear();
            hiddenInput.value = '';
        });
    }
});