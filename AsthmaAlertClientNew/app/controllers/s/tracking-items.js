import Controller from '@ember/controller';

export default Controller.extend({
    actions: {
        userDidDeleteAccount(){
            console.log("before this.store");
            this.store.createRecord('tracking-item', {
                trackingTitle: this.get('trackingItem.trackingTitle'),
                date: this.get('trackingItem.date'),
                hadAttack: this.get('trackingItem.hadAttack')
            }).save();
            console.log("after this.store");
        }
    }
});
