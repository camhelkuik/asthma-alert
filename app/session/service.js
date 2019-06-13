import DS from 'ember-data';
import { computed } from '@ember/object';
import ESASession from "ember-simple-auth/services/session";
import { inject } from '@ember/service';

export default ESASession.extend({
    store: inject(),

    currentUser: computed('isAuthenticated', function() {
      if (this.get('isAuthenticated')) {
        const promise = this.get('store').queryRecord('user', {})
        return DS.PromiseObject.create({ promise: promise })
      }
    })
});
