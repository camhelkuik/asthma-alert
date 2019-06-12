import Controller from '@ember/controller';

export default Controller.extend({

    responseMessage: '',
    getDate() {
        let today = new Date();
        let yesterday = new Date(today);
        
        yesterday.setDate(today.getDate() - 1);

        let dd = yesterday.getDate();
        let mm = yesterday.getMonth()+1; //January is 0!
        let yyyy = yesterday.getFullYear();
        
        if(dd<10){
            dd='0'+dd
        } 
        if(mm<10){
            mm='0'+mm
        } 
        yesterday = yyyy+'-'+mm+'-'+dd;
        return yesterday;
    },

    actions:{
        yesGoodDay(){
            //send userid, date and hadAttack of 0 to database
            
            const newGoodDay = this.store.createRecord('tracking', { hadAttack: 0, date: this.getDate(),  userId: 1  });
            newGoodDay.save();

            this.set('responseMessage', 'YAY for Linus and his lungs!!');
        },

        noBadDay(){
            //send userid, date and hadAttack of 1 to database

            const newBadDay = this.store.createRecord('tracking', { hadAttack: 1, date: this.getDate(),  userId: 1  });
            newBadDay.save();
            
            this.set('responseMessage', 'Too bad, hopefully tomorrow is better.');
        }
    }
});
