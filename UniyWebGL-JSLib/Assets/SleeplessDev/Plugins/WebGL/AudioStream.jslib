// AudioStreamPlugin.jslib
mergeInto(LibraryManager.library, {
    GetLocalStream: function() {
        navigator.mediaDevices
            .getUserMedia({ video: false, audio: true })
            .then((stream) => {
                window.localStream = stream;
                if (!window.localAudio) {
                    window.localAudio = document.createElement('audio');
                    document.body.appendChild(window.localAudio);
                }
                window.localAudio.srcObject = stream;
                window.localAudio.autoplay = true;
            })
            .catch((err) => {
                console.error(`You got an error: ${err}`);
            });
    }
});
