import DS from 'ember-data';

export default DS.Model.extend({
    date: DS.attr("string"),
    ozoneValue: DS.attr("number"),
    ozoneCategory: DS.attr("string"),
    grass: DS.attr("number"),
    mold: DS.attr("number"),
    ragweed: DS.attr("number"),
    tree: DS.attr("number")
});
