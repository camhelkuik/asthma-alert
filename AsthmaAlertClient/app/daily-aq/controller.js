import Controller from '@ember/controller';
import $ from 'jquery';
import EmberObject from '@ember/object';
import { run } from '@ember/runloop';

export default Controller.extend({
    hasAqData: false,
    aqData: null,
    asthmaValue: null,
    asthmaCategory: null,
    dustDanderCategory: null,
    dustDanderValue: null,
    humanDate: null,
    getDustDander: function(){
        $.get("http://dataservice.accuweather.com/indices/v1/daily/1day/349291/groups/1?apikey=y3bDUp7pmwjK9HjzWV6gkrNRorKYpkLI").then((response) => {

            var asthmaData = EmberObject.create({
                asthmaValue: response[23].Value,
                asthmaCategory: response[23].Category,
                dustDanderValue: response[19].Value,
                dustDanderCategory: response[19].Category
            });

            run(() => {
                this.set('asthmaCategory', asthmaData.asthmaCategory);
                this.set('asthmaValue', asthmaData.asthmaValue);
                this.set('dustDanderCategory', asthmaData.dustDanderCategory);
                this.set('dustDanderValue', asthmaData.dustDanderValue);
            });
        });
    },

    actions: {
        getDailyAq() {
            this.getDustDander();

            $.get("http://dataservice.accuweather.com/forecasts/v1/daily/1day/349291?apikey=y3bDUp7pmwjK9HjzWV6gkrNRorKYpkLI&details=true").then((response) => {
                
                var aqData = EmberObject.create({
                    date: response.DailyForecasts[0].Date,
                    ozoneValue: response.DailyForecasts[0].AirAndPollen[0].CategoryValue,
                    ozoneCategory: response.DailyForecasts[0].AirAndPollen[0].Category,
                    grass: response.DailyForecasts[0].AirAndPollen[1].CategoryValue, 
                    mold: response.DailyForecasts[0].AirAndPollen[2].CategoryValue,
                    ragweed: response.DailyForecasts[0].AirAndPollen[3].CategoryValue,
                    tree: response.DailyForecasts[0].AirAndPollen[4].CategoryValue
                });
                
                run(() => {
                    this.set('aqData', aqData);
                    this.set('hasAqData', true);
                    let humanDate = aqData.date.split("T")[0];
                    this.set('humanDate', humanDate);
    
                    const dailyAq = this.store.createRecord('daily-aq', { date: humanDate, ozoneValue: this.get('aqData.ozoneValue'), ozoneCategory: this.get('aqData.ozoneCategory'),
                    grass: this.get('aqData.grass'), mold: this.get('aqData.mold'), ragweed: this.get('aqData.ragweed'), tree: this.get('aqData.tree'),  asthmaValue: this.get('asthmaValue'),
                    asthmaCategory: this.get('asthmaCategory'), dustDanderValue: this.get('dustDanderValue'), dustDanderCategory: this.get('dustDanderCategory')});
                
                     dailyAq.save();
                })
            });
        }
    }
});
