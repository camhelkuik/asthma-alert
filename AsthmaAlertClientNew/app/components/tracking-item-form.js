import Component from '@ember/component';

export default Component.extend({
    actions: {
        launchConfrimShown(){
            this.onConfirm();
            console.log("inside sendSave after the this.get");
        }
    }
});
