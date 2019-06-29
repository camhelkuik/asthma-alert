import Controller from '@ember/controller';
import { inject as service } from '@ember/service'

export default Controller.extend({
    session: service(),

    actions: {
        save(user){
            let newUser = user;
            //need to generate a user id here Or can firebase assign one???
            newUser.save().catch((error) => {
                this.set('errorMessage', error);
            })
            .then(() => {
                this.get('session')
                .authenticate('authenticator:oauth2', newUser.get('email'), newUser.get('password'))
                .catch((reason) => {
                    this.set('errorMessage', reason.error || reason);
                });
            })
        }
    }
});
