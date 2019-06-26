import { helper } from '@ember/component/helper';

export function aqValue([params]/*, hash*/) {
  switch (params){
    case 1:
      return "Good";
    case 2:
      return "Moderate";
    case 3:
      return "Unhealthy for Sensitive Groups";
    case 4:
      return "Unhealthy";
    case 5:
      return "Very Unhealthy";
    case 6:
      return "Hazardous";
    default:
      return "No Information";    
  }
}

export default helper(aqValue);
