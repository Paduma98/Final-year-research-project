//.............. ...Start Swiper Story ................
let swiper = new Swiper(".mySwiper",{
    slidesPerView: 5,
    spaceBetween : 5,
});


// ..................Window Scroll.................
window.addEventListener('scroll',()=>{
    document.querySelector('.profile-popup').style.display='none'
    document.querySelector('.add-post-popup').style.display='none'
    document.querySelector('.theme-customize').style.display='none'
    document.querySelector('.notification-box').style.display='none'
});



function addActivity() {
    const activityInput = document.getElementById('activity-input').value.trim();
    if (activityInput === '') {
        return;
    }

    const activitiesList = document.getElementById('activities-list');
    const activityItem = document.createElement('li');
    activityItem.textContent = activityInput;
    activitiesList.appendChild(activityItem);
    document.getElementById('activity-input').value = '';
}

function finishActivities() {
    const teacherActivities = document.getElementById('teacher-activities');
    teacherActivities.style.display = 'none';
}

document.getElementById('teacher').addEventListener('change', function () {
    const teacherActivities = document.getElementById('teacher-activities');
    teacherActivities.style.display = this.checked ? 'block' : 'none';
});
