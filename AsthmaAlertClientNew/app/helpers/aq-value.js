import { helper } from '@ember/component/helper';

export function aqValue([params]/*, hash*/) {
  switch (params){
    case 1:
      return "Low";
    case 2:
      return "Moderate";
    case 3:
      return "High";
    case 4:
      return "Very High";
    case 5:
      return "Extreme";
    default:
      return "No Information";    
  }
}

export default helper(aqValue);
