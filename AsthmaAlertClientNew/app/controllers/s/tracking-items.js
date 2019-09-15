import Controller from '@ember/controller';

export default Controller.extend({
    actions: {
        saveAction(){
            // this.store.createRecord('tracking-item', {
            //     trackingTitle: this.get('tracking-item.trackingTitle'),
            //     date: this.get('tracking-item.date'),
            //     hadAttack: this.get('tracking-item.hadAttack')
            // }).save();
            this.get('model').save();
        }
    }
});
