import Controller from '@ember/controller';

export default Controller.extend({

    responseMessage: '',
    getDate() {
        let d = new Date().toISOString().split('T')[0];
        return d;
    },

    actions:{
        yesGoodDay(){
            //send userid, date and hadAttack of 0 to database
            
            const newGoodDay = this.store.createRecord('tracking', { hadAttack: 0 }, { date: this.getDate() }, { userId: 1 });
            newGoodDay.save();

            this.set('responseMessage', 'YAY for Linus and his lungs!!');
        },

        noBadDay(){
            //send userid, date and hadAttack of 1 to database

            const newBadDay = this.store.createRecord('tracking', { hadAttack: 1 }, { date: this.getDate() }, { userId: 1 });
            newBadDay.save();
            
            this.set('responseMessage', 'Too bad, hopefully tomorrow is better.');
        }
    }
});
