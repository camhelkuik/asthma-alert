import DS from 'ember-data';

export default DS.Model.extend({
    firstName: DS.attr("string"),
    lastName: DS.attr("string"),
    trackingItems: DS.hasMany("tracking-item")
});
