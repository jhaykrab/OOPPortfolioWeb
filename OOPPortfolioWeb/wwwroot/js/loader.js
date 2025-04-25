document.addEventListener("DOMContentLoaded", function () {
    const loader = document.getElementById("loader");

    let loaderTimeout;
    document.querySelectorAll("a.nav-link, form").forEach(element => {
        element.addEventListener("click", function () {
            loaderTimeout = setTimeout(() => loader.classList.remove("d-none"), 200);
        });
    });

    window.addEventListener("load", function () {
        clearTimeout(loaderTimeout);
        loader.classList.add("d-none");
    });


    // Show loader when a navigation link is clicked
    document.querySelectorAll("a.nav-link").forEach(link => {
        link.addEventListener("click", function () {
            loader.classList.remove("d-none");
        });
    });

    // Show loader when a form is submitted
    document.querySelectorAll("form").forEach(form => {
        form.addEventListener("submit", function () {
            loader.classList.remove("d-none");
        });
    });

    // Hide loader after page load (in case it was shown previously)
    window.addEventListener("load", function () {
        loader.classList.add("d-none");
    });
});
