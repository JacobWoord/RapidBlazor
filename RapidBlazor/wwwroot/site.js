function initializeFullpage() {
    new fullpage('#fullpage', {
        autoScrolling: true,
        scrollHorizontally: true
    });
}

function destroyFullpage() {
    if (window.fullpage_api) {
        window.fullpage_api.destroy('all');
    }
}




