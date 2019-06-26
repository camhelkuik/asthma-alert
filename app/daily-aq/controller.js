import Controller from '@ember/controller';
import $ from 'jquery';
import EmberObject from '@ember/object';
import { run } from '@ember/runloop';

export default Controller.extend({
    hasAqData: false,
    aqData: null,

    actions: {
        getDailyAq() {
            $.get("http://www.airnowapi.org/aq/forecast/zipCode/?format=application/json&zipCode=68108&API_KEY=4AE6A351-6AF4-42A8-808F-06E27D32BE1D").then((response) => {
                
                var aqData = EmberObject.create({
                    date: response.data[0].DateIssue,
                    ozone: response.data[0].ParameterName,
                    ozoneAQI: response.data[0].AQI,
                    ozoneCategory: response.data[0].Category.Number,
                    fineParticles: response.data[1].ParameterName,
                    fineParticlesAQI: response.data[1].AQI,
                    fineParticlesCategory: response.data[1].Category.Number,
                    combined: response.data[2].ParameterName,
                    combinedAQI: response.data[2].AQI,
                    combinedCategory: response.data[2].Category.Number
                });
                
                run(() => {
                    this.set('aqData', aqData);
                    this.set('hasAqData', true);
    
                    const dailyAq = this.store.createRecord('daily-aq', { date: this.get('aqData.date'), ozone: this.get('aqData.ozone'), ozoneAQI: this.get('aqData.ozoneAQI'),
                    ozoneCategory: this.get('aqData.ozoneCategory'), fineParticles: this.get('aqData.fineParticles'), fineParticlesAQI: this.get('aqData.fineParticlesAQI'),
                    fineParticlesCategory: this.get('aqData.fineParticlesCategory'), combined: this.get('aqData.combined'), combinedAQI: this.get('aqData.combinedAQI'),
                    combinedCategory: this.get('aqData.combinedCategory') });
                
                     dailyAq.save();
                })
            });
        }
    }
});
