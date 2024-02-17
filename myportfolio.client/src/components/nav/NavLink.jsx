import PropTypes from 'prop-types';

export default function NavLink({ text, url }) {
    return <li><a className="navlink" href={url}>{text}</a></li>
}

NavLink.propTypes = {
    text: PropTypes.string.isRequired,
    url: PropTypes.string.isRequired
}