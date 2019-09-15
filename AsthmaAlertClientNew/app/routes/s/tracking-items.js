import Route from '@ember/routing/route';

export default Route.extend({
    model(){
       //return this.store.findAll('tracking-item');
       return this.store.createRecord('tracking-item');
    }
});
